//Intialize Array
public static class ArrayExtentions
{
public static void Init<T>(this T[] array, T defaultValue)
{
  if(array == null)
    return;
    
    for(int i = 0; i < array.Length; i++)
    {
      array[i] = defaultValue;
    }
}

public static void Populate<T>(this T[] arr, T value ) {
  for ( int i = 0; i < arr.Length;i++ ) {
    arr[i] = value;
  }
}

}
