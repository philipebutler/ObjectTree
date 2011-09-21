using NUnit.Framework;
using System;
using ObjectTree;

namespace ObjectTree.Test
{
	[TestFixture()]
	public class ObjectTreeTest
	{
		[Test()]
		public void InitialTestCase ()
		{
			//Arrange
			ObjectTreeNode source = new ObjectTreeNode();
			source.Name = "Test Node Name";
			string sourceValue = "Test String Object";
			source.Value = sourceValue;
			string target = "Test String Object";
			
			//Assert
			Assert.AreEqual(target,(string)source.Value);
		}
	}
}

