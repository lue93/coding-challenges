class Node:
   def __init__(self, dataval=None):
      self.dataval = dataval
      self.nextval = None

class SLinkedList:
   def __init__(self):
      self.headval = None

   # Print the linked list
   def listprint(self):
      printval = self.headval
      while printval is not None:
         print (printval.dataval)
         printval = printval.nextval
   
   def AtBegining(self,newdata):
      NewNode = Node(newdata)

      # Update the new nodes next val to existing node
      NewNode.nextval = self.headval
      self.headval = NewNode

   def FindOdd(self):
      printval = self.headval
      while printval is not None:
         if (printval.dataval % 2 ) == 0:
            # removendo o elemento
            self.RemoveNode(printval)
         printval = printval.nextval

      # exibindo a lista modificada
      self.listprint()

   
   # Function to remove node
   def RemoveNode(self, Removekey):
      HeadVal = self.headval

      if (HeadVal is not None):
         if (HeadVal == Removekey):
            self.head = HeadVal.nextval
            HeadVal = None
            return
      while (HeadVal is not None):
         if HeadVal == Removekey:
            break
         prev = HeadVal
         HeadVal = HeadVal.nextval

      if (HeadVal == None):
         return

      prev.nextval = HeadVal.nextval
      HeadVal = None



#####################  interact ###########################
# esse trecho poderia estar no arquivo main

list = SLinkedList()
list.headval = Node(0)
e1 = Node(1)
e2 = Node(2)
e3 = Node(3)
e4 = Node(4)
e5 = Node(5)
e6 = Node(6)
e7 = Node(7)

list.headval.nextval = e1
e1.nextval = e2
e2.nextval = e3
e3.nextval = e4
e4.nextval = e5
e5.nextval = e6
e6.nextval = e7

print('antes')
list.listprint()
print('depois')
list.FindOdd()



