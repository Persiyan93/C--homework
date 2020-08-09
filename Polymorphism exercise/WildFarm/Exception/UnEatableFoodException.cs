using System;


namespace WildFarm.Exception
{
    public class UnEatableFoodException :SystemException
    {
        public UnEatableFoodException(string message):
            base(message)
        {

        }
    }
}
