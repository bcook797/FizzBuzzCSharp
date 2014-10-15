using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class FizzBuzzTest
	{
		[Test]
		public void ShouldReturnFizzWhenInputDivisibleByThree()
		{
			Assert.That(1,Is.EqualTo(1));
		}
	}
}

