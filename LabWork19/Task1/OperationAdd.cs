﻿namespace Task1
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}