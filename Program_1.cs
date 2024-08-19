namespace async_task
{
    class Program_1
    {
        /*
        static async Task Main(string[] args)
        {
            //也可以 使用二次
            Method1();
            //await Method1(); //若設此處，就會待所有m1執行完後。才會執行m2，m3。這個例子若這樣此定，等同同步的m1.m2.m3。
            Method2();
            await Method1();   //若設此處，就會待所有m1執行完後。才會執行m3。所以m3一定為最後。   若沒有設，則就依程式自己執行1.2.3彼此可能交雜結果。
            Console.WriteLine(" Method 3 end");
            Console.ReadKey();
        }
        
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
        */
    }
}
