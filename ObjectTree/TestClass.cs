using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectTree
{
	public class TestClass : ICollection<ObjectTreeNode>
	{
		public TestClass ()
		{
		
		}
		
		// Methods
		public void Add (ObjectTreeNode item){
			throw new NotImplementedException();
		}
		
		public void Clear (){
			throw new NotImplementedException();
		}
		
		public bool Contains (ObjectTreeNode item){
			throw new NotImplementedException();
			return null;
		}
		
		public void CopyTo (ObjectTreeNode[] array, int arrayIndex){
			throw new NotImplementedException();
		}
		
		public bool Remove (ObjectTreeNode item){
			return null;
		}

		// Properties
		public int Count { get; }
		public bool IsReadOnly { get; }
		
	}
}

