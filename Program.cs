namespace async_task
{
    class Program
    {
/*
        static async Task Main(string[] args)
        {
            //也可以 使用二次
            //Method1();
            await Method1(); //若設此處，就會待所有m1執行完後。才會執行m2，m3。這個例子若這樣此定，等同同步的m1.m2.m3。
            Method2();            
            Console.WriteLine(" Method 3 end");
            Console.ReadKey();
        }
*/       
        static async Task Main(string[] args)
        {
            //Method1();
            //await Method1(); //若設此處，就會待所有m1執行完後。才會執行m2，m3。這個例子若這樣此定，等同同步的m1.m2.m3。
            Method2();
            await Method1();
            Console.WriteLine(" Method 3 end");
            Console.ReadKey();
        }
        /*
                static async Task Main(string[] args)
                {   
                    //先執行完同步的m2 才會做下一步
                    Method2();
                    //使用await就會待所有m1執行完後。才會執行主線程m3。所以m3一定為最後。
                    //  若沒有使用await，則就依程式自己執行1.2.3彼此可能交雜結果。
                    //(記得各函式的延遲夠大，不然結果可能不會交雜，因為一下就處理好了)
                    //(無使用await，即使函式裡頭有await也不理會當作無await！)
                    await Method1(); 
                    Console.WriteLine(" Method 3 end");
                    Console.ReadKey();
                }
          */
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i <60; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
    }
}
