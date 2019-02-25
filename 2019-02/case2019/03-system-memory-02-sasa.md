## `System.Memory` 02

*   `Memory<T>`
    *   Like Span<T>, Memory<T> represents a contiguous region of memory.
    *   Unlike Span<T>, however, Memory<T> is not a ref struct.
    *   Can be placed on the managed heap.
    *   It can be used as a field in a class.
    *   It can be used across await and yield boundaries.