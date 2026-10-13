
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GithubActionsLab;

[TestClass]
public class Addition
{
    [TestMethod]
    public void Add_Valid_Ewane()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Ewane()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Ewane()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid()
    {
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(-2, Program.Subtract("3", "5"));
        Assert.AreEqual(0, Program.Subtract("4", "4"));
    }

    [TestMethod]
    public void Subtract_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "b"));
    }

    [TestMethod]
    public void Subtract_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid()
    {
        Assert.AreEqual(12, Program.Multiply("3", "4"));
        Assert.AreEqual(-10, Program.Multiply("-2", "5"));
        Assert.AreEqual(0, Program.Multiply("0", "8"));
    }

    [TestMethod]
    public void Multiply_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "b"));
    }

    [TestMethod]
    public void Multiply_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid()
    {
        Assert.AreEqual(5, Program.Divide("10", "2"));
        Assert.AreEqual(-3, Program.Divide("-9", "3"));
        Assert.AreEqual(0, Program.Divide("0", "5"));
    }

    [TestMethod]
    public void Divide_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "b"));
    }

    [TestMethod]
    public void Divide_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}

[TestClass]
public class PowerTests
{
    [TestMethod]
    public void Power_Valid()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(25, Program.Power("5", "2"));
        Assert.AreEqual(1, Program.Power("7", "0"));
    }

    [TestMethod]
    public void Power_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "b"));
    }

    [TestMethod]
    public void Power_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
