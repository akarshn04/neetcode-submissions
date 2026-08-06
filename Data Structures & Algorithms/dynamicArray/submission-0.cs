public class DynamicArray {
    public int size {get;set;}
    
    private int _counter = 0;

    public int[] arr {get;set;}

    public DynamicArray(int capacity) {
        size = capacity;
        arr = new int[capacity];
    }

    public int Get(int i) {
      if(i>=0 && i<_counter)
      {
        return arr[i];
      }
      else return -1;
    }

    public void Set(int i, int n) {
     if(i>=0 && i<_counter)
      {
        arr[i]=n;
      }
    }

    public void PushBack(int n) {
        if(_counter == arr.Length)
            Resize();

        arr[_counter++] = n;
    }

    public int PopBack() {
        if(_counter>0)
        {
            _counter--;
            return arr[_counter];
        }
        return -1;
    }

    private void Resize() {
        size = 2*size;
        int[] arr2 = new int[size];
        int i=0;
        foreach(var item in arr)
        {
            arr2[i++] = item;
        }
        arr = arr2;
    }

    public int GetSize() {
        return _counter;
    }

    public int GetCapacity() {
        return size;
    }
}
