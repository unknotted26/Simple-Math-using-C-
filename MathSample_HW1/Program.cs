﻿/*
 * There is no implicit declarations in C# compared to C++. For example, Square square; is invalid
 * because if square were to be used (ex. square.width), the compiler would return "use of unassigned 
 * local variable." To resolve this do Square square = new Square();
 * 
 * Any class in c# is a reference class.
 * If you pass a variable into a function where the function parameter is of type 'out', then that variable
 * will be reinitialized to 0. Example: OutIntChange(out myInt){ return ++myInt; } // myInt = 1 regardless of previous value.
 * 
 * A class cannot inherit from another class whose access denomination is higher.
 * Example: Given "public class Polygon", "class Square : Polygon" would be illegal
 * because Square has an access of 'internal' (note: it's not explicitly specified). To
 * resolve this issue, must define Square class as : "public class Square." 
 * 
 * Static classes must derive from objects.
 * 
 * Abstract classes can't be instantiated and they must be inherited. Abstract methods are implicitly
 * virtual and are only allowed in abstract classes.
 * 
 * "sealed" modifier prevents a class from being inherited
 * 
 * C# does not allow deterministic disposition of objects, etc. hench managed data.
 * 
 * Using delegates, the library can be altered at runtime.
 * 
 * Delegates are used to pass methods as arguments to other methods. Compare this to C function pointers.
 * 
 * The ref and out keywords cause different run-time behavior and they are not considered part of the
 * method signature at compile time. Thus methods cannot be overloaded if the difference only has to do
 * with the inclusion/ exclusion of these keywords.
 * 
 * [1] http://www.codeproject.com/Articles/992340/Generic-Math-in-Csharp-Using-Runtime-Compilation
 * 
 * Parse returns an exception and TryParse returns false.
 * 
 * https://msdn.microsoft.com/en-us/library/ms229597(v=vs.110).aspx
 * 
 * Running the program below via CMD (csc Program.cs, Program.exe) will only display the windows form. If
 * it is run and built here in VS, a console window will open along with the windows form.
 * 
 * Features I'd like to implement:
 * https://msdn.microsoft.com/en-us/library/xyhh2e7e(v=vs.110).aspx
 * 
 * No implicit conversion is allowed in c#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.CodeDom.Compiler; // CompilerParameters, GenerateInMemory
using Microsoft.CSharp;        // CSharpCodeProvider
using System.Reflection;       // MethodInfo

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using PClass2;
// using PClass3;

namespace MathProgram
{
    // aliases (can also be declared in global namespace). Closest thing to C++ typedef
    // using Polygon = PClass2.Polygon<double>; // Contains virtual area()
    // using Polygon = PClass3.Polygon;      // Abstract (Pure virtual in C++) implementation

    class Program 
    {
        public Program()  
        {

        }

        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //Program());
        }
    } // class Program

    public class Square<T> : Polygon<T>
    {
        public Square() { }
        public override T area()
        {
            return Generic_Math<T>.Product(new T[] { width, height });
        }
    }
    
    public class Triangle<T> : Polygon<T>
    {
        public override T area()
        {
            return Generic_Math<T>.Product(new T[] { (T)Convert.ChangeType(0.5, typeof(T)), width, height });
        }
    }
   
    public static class Generic_Math<T>   // see top comment [1]
    {
        public static Func<T[], T> Sum = (T[] array) =>
        {
            string code = "(System.Func<NUMBER[], NUMBER>)((NUMBER[] array) => { NUMBER sum = 0; for (int i = 0; i < array.Length; i++) sum += array[i]; return sum; })";
            code = code.Replace("NUMBER", typeof(T).ToString());
            Generic_Math<T>.Sum = Generate.Object< Func<T[], T> >(new string[] { }, new string[] { }, code);
            return Generic_Math<T>.Sum(array);
        };

        public static Func<T[], T> Product = (T[] array) =>
        {
            string code = "(System.Func<NUMBER[], NUMBER>)((NUMBER[] array) => { NUMBER product = 1; for (int i = 0; i < array.Length; i++) product *= array[i]; return product; })";
            code = code.Replace("NUMBER", typeof(T).ToString());
            Generic_Math<T>.Product = Generate.Object< Func<T[], T> >(new string[] { }, new string[] { }, code);
            return Generic_Math<T>.Product(array);
        };
    }

    internal static class Generate  // see top comment [1]
    {
        internal static T Object<T>(string[] references, string[] name_spaces, string code)
        {
            string full_code = string.Empty;
            if (name_spaces != null)
                for (int i = 0; i < name_spaces.Length; i++)
                    full_code += "using " + name_spaces[i] + ";";

            full_code += "namespace Seven.Generated {";
            full_code += "public class Generator {";
            full_code += "public static object Generate() { return " + code + "; } } }";

            CompilerParameters parameters = new CompilerParameters();
            foreach (string reference in references)
                parameters.ReferencedAssemblies.Add(reference);

            parameters.GenerateInMemory = true;
            CompilerResults results = new CSharpCodeProvider().CompileAssemblyFromSource(parameters, full_code);

            if(results.Errors.HasErrors)
            {
                string error = string.Empty;
                foreach (CompilerError compiler_error in results.Errors)
                    error += compiler_error.ErrorText.ToString() + "\n";

                throw new Exception(error);
            }
            
            MethodInfo generate = results.CompiledAssembly.GetType("Seven.Generated.Generator").GetMethod("Generate");

            return (T)generate.Invoke(null, null);
        }
    }
}

// Contains class Polygon with a virtual function
namespace PClass2
{
    public class Polygon<T>
    {
        private T _width;
        private T _height;

        public T width {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public T height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public virtual T area() { return (T)Convert.ChangeType(0, typeof(T)); }
        public Polygon()
        {
            // width = 0;
            // height = 0;
        }

        public Polygon(T w, T h)
        {
            width = w;
            height = h;
        }
    }
}

/*
// Contains an abstract Polygon class
namespace PClass3
{
    public abstract class Polygon
    {
        public uint width { get; set; }
        public uint height { get; set; }

        
        public abstract double area();
        public Polygon()
        {
            width = 0;
            height = 0;
        }

        public Polygon(uint w, uint h)
        {
            width = w;
            height = h;
        }
    }
}
*/
