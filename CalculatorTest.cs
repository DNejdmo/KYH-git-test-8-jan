﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace calc
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            //given
            Calculator calc = new();
            int a = 5;
            int b = 2;
            int expectedResult = 7;


            //when
            int result = calc.Add(a, b);


            //then
            Assert.Equal(expectedResult, result);

        }
        [Fact]
        public void TestSubtract()
        {
            //given
            Calculator calc = new();
            int a = 5;
            int b = 2;
            int expectedResult = 3;


            //when
            int result = calc.Subtract(a, b);


            //then
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestMultiply()
        {
            //given
            Calculator calc = new();
            int a = 5;
            int b = 2;
            int expectedResult = 10;


            //when
            int result = calc.Multiply(a, b);


            //then
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestDivide()
        {
            //given
            Calculator calc = new();
            int a = 10;
            int b = 2;
            int expectedResult = 5;


            //when
            int result = calc.Divide(a, b);


            //then
            Assert.Equal(expectedResult, result);
        }
    }
}
