// package main -- go2cs converted at 2018 July 17 05:02:49 UTC
// Original source: C:\Projects\go2cs\src\Tests\Behavioral\StructPromotionWithInterface.go

using fmt = go.fmt_package;
using time = go.time_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        // Above type comment
        // Top inner type comment
        public partial interface Abser
        {
            float64 Abs(); // To the right comments
        }

        // Middle type comment
        public partial struct MyError
        {
            public time.Time When;
            public @string What;
        }

        // Weirdly placed comment

        public partial struct MyCustomError : Abser, error
        {
            public @string Message; // My custom error message
            public Abser Abser;
            public ref MyError MyError => ref MyError_val;
            public error error;
        }

        // Bottom inner type comment

        // Below type comment

        // The following takes precedence over instance call to Abs()
        public static float64 Abs(this ref MyCustomError myErr)
        {
            return 0.0;
        }

        private static void Main()
        {
            var a = MyCustomError{"New One",nil,MyError{time.Now(),"Hello"}};
            a.Abs();
            a.Message = "New";
            fmt.Println("MyCustomError method =", a.Abs());
        }
    }
}
