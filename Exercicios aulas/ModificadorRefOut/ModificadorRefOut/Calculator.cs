namespace ModificadorRefOut
{
    class Calculator
    {
        // REF
        public static void Triple (ref int x)
        {
            x = x * 3;
        }
        // OUT
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
