namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Moondra()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Moondra()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Moondra()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class PowerTests
{
	[TestMethod]
	public void Power_Valid_Moondra()
	{
		Assert.AreEqual(8.0, Program.Power("2", "3"));
		Assert.AreEqual(1.0, Program.Power("5", "0"));
		Assert.AreEqual(0.25, Program.Power("2", "-2"));
	}

	[TestMethod]
	public void Power_Invalid_Moondra()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
	}

	[TestMethod]
	public void Power_Null_Moondra()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
	}
}

[TestClass]
public class SubtractionTests
{
	[TestMethod]
	public void Subtract_Valid_Moondra()
	{
		Assert.AreEqual(1.0, Program.Subtract("3", "2"));
		Assert.AreEqual(-2.0, Program.Subtract("3", "5"));
		Assert.AreEqual(0.0, Program.Subtract("5", "5"));
	}

	[TestMethod]
	public void Subtract_Invalid_Moondra()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("2", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Moondra()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("2", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
	}
}

[TestClass]
public class MultiplicationTests
{
	[TestMethod]
	public void Multiply_Valid_Moondra()
	{
		Assert.AreEqual(6.0, Program.Multiply("2", "3"));
		Assert.AreEqual(-6.0, Program.Multiply("-2", "3"));
		Assert.AreEqual(0.0, Program.Multiply("0", "3"));
	}

	[TestMethod]
	public void Multiply_Invalid_Moondra()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Moondra()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
	}
}

[TestClass]
public class DivisionTests
{
	[TestMethod]
	public void Divide_Valid_Moondra()
	{
		Assert.AreEqual(2.0, Program.Divide("6", "3"));
		Assert.AreEqual(-2.0, Program.Divide("6", "-3"));
		Assert.AreEqual(0.0, Program.Divide("0", "3"));
	}

	[TestMethod]
	public void Divide_Invalid_Moondra()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("2", "a"));
	}

	[TestMethod]
	public void Divide_Null_Moondra()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
	}
}
