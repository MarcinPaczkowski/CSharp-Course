namespace Introduction
{
    public static class StaticClass
    {
        static StaticClass()
        {
            var x = 1;
        }

        public static bool Value1 { get; set; }

        public static string Value2 { get; set; }

        public static int Method1(int value)
        {
            return value + 1;
        }
    }
}