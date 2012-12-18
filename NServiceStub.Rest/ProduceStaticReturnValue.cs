﻿namespace NServiceStub.Rest
{
    public class ProduceStaticReturnValue<R> : IInvocationReturnValueProducer<R>
    {
        private readonly R _returnValue;

        public ProduceStaticReturnValue(R returnValue)
        {
            _returnValue = returnValue;
        }

        public R Produce(string rawUrl, IRouteDefinition route)
        {
            return _returnValue;
        }
    }
}