using Castle.DynamicProxy;
using System;

namespace Trinity.IoC.Interceptor
{
    public class DefaultInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if (invocation.Method.IsPublic)
            {
                Console.WriteLine("Interception Begin");

                try { 
                    invocation.Proceed();
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine($"Interception exception : {e.Message}");
                }

                Console.WriteLine("Interception End");

            }
            else
            {
                Console.WriteLine("No interception");
            }

        }
    }
}
