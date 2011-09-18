using System;
using System.Collections.Generic;
namespace ObjectTree
{
	public class ObjectTreeNodeEnumerator : IEnumerator<ObjectTreeNode>	
	{
		
		//Local Variables
		ObjectTreeNodeCollection _collection;
		
		int curIndex;
		
		ObjectTreeNode curObjectTreeNode;
		
		
		public ObjectTreeNodeEnumerator (ObjectTreeNodeCollection collection) : base()
		{
			
			_collection = collection;
			
			curIndex = -1;
			
			curObjectTreeNode = null;
			
		}
		
		public ObjectTreeNode Current
        {
			
            get { 
			
				if (curObjectTreeNode == null){
					
					throw new InvalidOperationException();
					
				}
				
				return curObjectTreeNode;
				
			}
			
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            
			curIndex += 1;
			
			if(curIndex == _collection.Count){
				
				return false;
				
			}else{
				
				curObjectTreeNode = _collection.GetItem[curIndex];
				
			}
			
			return true;
			
        }

        public void Reset()
        {
            
			curIndex = -1;
			
        }
	}
}

