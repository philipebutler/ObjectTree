using System;
namespace ObjectTree
{
	public class ObjectTreeNode
	{
		public ObjectTreeNode Parent {get; set;}
		public Object Value {get; set;}
		public string Name {get; set;}
		public ObjectTreeNode ()
		{
		}
	}
}

