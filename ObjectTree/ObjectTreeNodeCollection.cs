using System;
using System.Collections.Generic;
using ObjectTree;
using System.Collections;

namespace ObjectTree
{
	public class ObjectTreeNodeCollection : ICollection<ObjectTreeNode>
	{
		//local variables
		private List<ObjectTreeNode> innerCol;
		
		private bool isRO = false;
		
		//Constructor
		public ObjectTreeNodeCollection ()
		{
			innerCol = new List<ObjectTreeNode>();
		}
		
		//Methods
		public void Add(ObjectTreeNode item)
        {
            if (!this.Contains(item)) {
				
				innerCol.Add(item);
				
			}
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(ObjectTreeNode item)
        {
            bool found = false;
			
			foreach (ObjectTreeNode otn in innerCol){
				
				if (otn.Equals(item)){
					
					found = true;
					
					break;
					
				}
				
			}
			
			return found;
        }

        public void CopyTo(ObjectTreeNode[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            
			get {
				
				return innerCol.Count;
				
			}
			
        }

        public bool IsReadOnly
        {
            
			get { 
				
				return isRO;
				
			}
			
        }

        public bool Remove(ObjectTreeNode item)
        {
			
			bool result = false;
			
            int i;
			
			for (i = 0; i <= innerCol.Count-1;i++){
			
				//ObjectTreeNode curObjectTreeNode = innerCol(i); 
				
				//curObjectTreeNode = innerCol(i) as ObjectTreeNode;
				
				if(this.innerCol[i].Equals(item)){
					
					innerCol.RemoveAt(i);
				
					result = true;
				
					break;
					
				}
			}
			
			return result;
			
        }

        public IEnumerator<ObjectTreeNode> GetEnumerator()
        {
            
			return new ObjectTreeNodeEnumerator(this);
			
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
			
            return this.GetEnumerator();
			
        }
		
		public ObjectTreeNode GetItem(int index){
			return innerCol[index];
		}
	}
}

