using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public  class Node<T>
    {
        public T item;
        public Node<T> next;

        /// <summary>
        /// To add element in to the linked list
        /// </summary>
        /// <param name="item">element that needs to be added to the linked list</param>
        public void add(T item)
        {
            Node<T> node = this;
            if (node.item==null)
            {
                node.item = item;
            }
            else
            {
                while (node.next != null)
                    node = node.next;
                node.next = new Node<T>();
                node.next.item = item;
            }

        }


        /// <summary>
        /// To Remove Element from the Linked List
        /// </summary>
        /// <param name="item">element that needs to be added to the linked list</param>
        public void remove(T item)
        {
            if (this.item == null)
                throw new NullReferenceException();
            Node<T> ptr = this;
            Node<T> prv = this;
            while(!ptr.item.Equals(item))
            {
                prv = ptr;
                ptr = ptr.next;
            }
            if(ptr==this)
            {
                ptr.item = ptr.next.item;
                ptr.next = ptr.next.next;                
            }
            else
            {
                prv.next = ptr.next;
            }
        }

        /// <summary>
        /// To check if the element is present in the list
        /// </summary>
        /// <param name="item">element that needs to be added to the linked list</param>
        /// <returns></returns>
        public T display(T item)
        {
            Node<T> ptr = this;
            while (!ptr.item.Equals(item))
                ptr = ptr.next;
            return ptr.item;
        }

        /// <summary>
        /// To pop element in the linked list to act as a Queue First in fisrt out (FIFO)
        /// </summary>
        public void pop()
        {
            Node<T> node = this;
            node.item = node.next.item;
            node.next = node.next.next;
        }

        /// <summary>
        /// To add element to the queue it remains same for stack or queue
        /// </summary>
        /// <param name="item">element that needs to be added to the linked list</param>
        public void push(T item)
        {
            add(item);
        }

        /// <summary>
        /// To delete element from the Linked list to act as a stack Last in first out (LIFO)
        /// </summary>
        public void delete()
        {
            Node<T> ptr = this;
            Node<T> prv = this;
            //Simple and Crude way to Push 
            //Need a better way to handel this may be a stateful node which can there be destroyed and have a garbage cleanup done 
            while (ptr.next != null)
            {
                prv = ptr;
                ptr = ptr.next;
            }
            prv.next = null;
        }

        public void insertAtposition(int position)
        {

        }
      
    }
}
