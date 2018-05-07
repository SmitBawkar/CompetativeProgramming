import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.text.DecimalFormat;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] a = new int[n];
        DecimalFormat df2 = new DecimalFormat(".#");
        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>();
        PriorityQueue<Integer> maxHeap = new PriorityQueue<Integer>(n,new Comparator<Integer>() {
            public int compare(Integer lhs, Integer rhs) {
            return (-1 * lhs.compareTo(rhs));
        }
       });
        for(int a_i=0; a_i < n; a_i++){            
            addElement(a[a_i] = in.nextInt(),minHeap,maxHeap);           
           int minHeapSize = minHeap.size();
            int maxHeapSize = maxHeap.size(); 
            
            if(minHeapSize == maxHeapSize)
            {
                System.out.println(df2.format((double)(minHeap.peek()+maxHeap.peek())/2));
            }
            else if(minHeapSize > maxHeapSize)
                System.out.println(df2.format(minHeap.peek()));
            else
                System.out.println(df2.format(maxHeap.peek()));                   
        }
    }
    public static void addElement(Integer el,PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap)
    {
      if(maxHeap.size() < 1)
          maxHeap.add(el);
      else if(el.compareTo(maxHeap.peek()) <= 0)
          maxHeap.add(el);
      else
          minHeap.add(el);                    
       maintainBalance(minHeap,maxHeap);  
    }
    public static void maintainBalance(PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap)
    {
        PriorityQueue<Integer> bigHeap;
        PriorityQueue<Integer> smallHeap;
        
        int minHeapSize = minHeap.size();
        int maxHeapSize = maxHeap.size(); 
        
        if(Math.abs(minHeapSize - maxHeapSize) >= 2)
        {
           bigHeap = minHeapSize > maxHeapSize ? minHeap : maxHeap;
           smallHeap = minHeapSize < maxHeapSize ? minHeap : maxHeap;           
           smallHeap.add(bigHeap.poll());
        }
    }
    
}
