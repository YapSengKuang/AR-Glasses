class Sorting{

    static void Main()    {
        int[] a={6,8,33,99,0,-2,11};
        mergesort(a);
        foreach(int i in a){
            Console.WriteLine(i);
        }
    }

    public static void mergesort(int[] x){
        int l = x.Length;
        if (l>1){
            int mid = l/2;
            int[] left = x[0..mid];
            int[] right = x[mid..];
            mergesort(left);
            mergesort(right);
            int i=0,j=0,k=0;
            
            while(i<left.Length & j<right.Length){
                if(left[i]<=right[j]){
                    x[k]=left[i];
                    i+=1;
                }
                else{
                    x[k]=right[j];
                    j+=1;
                }
                k+=1;
            }
            while (i<left.Length){
                x[k]=left[i];
                i+=1;
                k+=1;
            }
            while (j<right.Length){
                x[k]=right[j];
                j+=1;
                k+=1;
            }
        }
        return;
    }
}
