﻿namespace P03GenericSwapMethodString
{
    class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.value.GetType()}: {this.value}".ToString();
        }
    }
}
