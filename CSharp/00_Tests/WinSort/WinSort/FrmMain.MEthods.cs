using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSort
{
  public partial class FrmMain
  {
    private const int MAX_ELEMENTS = 5 * 10_000;
    private decimal[] _array;
    private Stopwatch _sw = new Stopwatch();


    private void SetStatus(string hint)
    {
      var txt = $"{hint} {_sw.Elapsed.TotalMilliseconds:N0} ms";
      lblStatus.Text = txt;
    }


    private void CreateArray()
    {
      _sw.Restart();
      _array = new decimal[MAX_ELEMENTS];
      var rand = new Random(DateTime.Now.Millisecond);

      for (int i = 0; i < MAX_ELEMENTS; i++)
      {
        var v = (decimal)rand.NextDouble();
        _array[i] = v;
      }
      _sw.Stop();

      SetStatus("CreateArray:");
    }


    private void BubbleSort()
    {
      _sw.Restart();
      SetStatus("Bubble-Sort-Start:");

      // idx: von 0 bis vorletztes! (Vergleich mit nächstem)
      // 0,1,2,3,4 ...24987,24988... 49998
      for (int i = 0; i < _array.Length - 1; i++)
      {
        // vom nächsten (1) bis zum letzten
        for (int j = i + 1; j < _array.Length; j++)
        {
          if (_array[i] > _array[j])
          {
            var tmp = _array[i];
            _array[i] = _array[j];
            _array[j] = tmp;
          }
        }
      }

      _sw.Stop();
      SetStatus("Bubble-Sort:");
    }


    private void DotNetSort()
    {
      _sw.Restart();

      Array.Sort(_array);
      Array.Reverse(_array);

      _sw.Stop();
      SetStatus("Dot-NET-Sort:");
    }


    private void QuickSort()
    {
      _sw.Restart();

      QuickSort(_array, 0, _array.Length-1);

      _sw.Stop();
      SetStatus("Quick-Sort:");
    }


    void MergeSort(int left, int right)
    {
      _sw.Restart();

      if (left < right)
      {
        // Find the middle
        // point
        int m = left + (right-left)/2;

        // Sort first and
        // second halves
        MergeSort(left, m);
        MergeSort(m + 1, right);

        // Merge the sorted halves
        Merge(left, m, right);
      }

      _sw.Stop();
      SetStatus("Merge-Sort:");
    }


    void Merge(int left, int m, int right)
    {
      // Find sizes of two
      // subarrays to be merged
      int n1 = m - left + 1;
      int n2 = right - m;

      // Create temp arrays
      decimal[] L = new decimal[n1];
      decimal[] R = new decimal[n2];
      int i, j;

      // Copy data to temp arrays
      for (i = 0; i < n1; ++i)
        L[i] = _array[left + i];
      for (j = 0; j < n2; ++j)
        R[j] = _array[m + 1 + j];

      // Merge the temp arrays

      // Initial indexes of first
      // and second subarrays
      i = 0;
      j = 0;

      // Initial index of merged
      // subarray array
      int k = left;
      while (i < n1 && j < n2)
      {
        if (L[i] <= R[j])
        {
          _array[k] = L[i];
          i++;
        }
        else
        {
          _array[k] = R[j];
          j++;
        }
        k++;
      }

      // Copy remaining elements
      // of L[] if any
      while (i < n1)
      {
        _array[k] = L[i];
        i++;
        k++;
      }

      // Copy remaining elements
      // of R[] if any
      while (j < n2)
      {
        _array[k] = R[j];
        j++;
        k++;
      }
    }



    private void QuickSort(decimal[] arr, int left, int right)
    {
      if (left < right)
      {
        int pivot = Partition(arr, left, right);

        if (pivot > 1)
        {
          QuickSort(arr, left, pivot - 1);
        }
        if (pivot + 1 < right)
        {
          QuickSort(arr, pivot + 1, right);
        }
      }

    }


    private int Partition(decimal[] arr, int left, int right)
    {
      var pivot = arr[left];
      while (true)
      {

        while (arr[left] < pivot)
        {
          left++;
        }

        while (arr[right] > pivot)
        {
          right--;
        }

        if (left < right)
        {
          if (arr[left] == arr[right])
            return right;

          var temp = arr[left];
          arr[left] = arr[right];
          arr[right] = temp;
        }
        else
        {
          return right;
        }
      }
    }


  }
}
