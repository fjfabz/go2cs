// package main -- go2cs converted at 2018 July 17 05:02:49 UTC
// Original source: C:\Projects\go2cs\src\Tests\Behavioral\TypeSwitch.go

using fmt = go.fmt_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        public partial interface I
        {
            @string m();
        }


        public partial struct T : I
        {
            public @string name;
            public I I;
        }


        private static @string m(this T @ref)
        {
            return @ref.name;
        }

        public partial struct S
        {
            public @string name;
        }


        private static @string m(this S @ref)
        {
            return "Am I an I?";
        }

        private static void Main()
        {
            EmptyInterface x = 7;          // x has dynamic type int and value 7
            var i = x.TypeAssert<@int>();                   // i has type int and value 7
            fmt.Println(i);

            T y;
            y.name = "Me";

            f(y);

            EmptyInterface s = S{"you"};

            Switch(s)
                .Case(typeof(I))(() =>
                {

                    fmt.Println("S is an I!!");
                })
                .Case(typeof(NilType), typeof(@int))(() =>
                {

                    fmt.Println("S is nil or an int");
                })
                .Default(() =>
                {

                    fmt.Println("S is not an I");
                })
;        }

        private static void f(I y)
        {

            //s := y.(string)        // illegal: string does not implement I (missing method m)
            //r := y.(io.Reader)     // r has type io.Reader and the dynamic type of y must implement both I and io.Reader
            fmt.Println(y.m());
        }
    }
}
