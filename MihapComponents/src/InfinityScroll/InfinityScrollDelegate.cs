namespace MihapComponents.InfinityScroll;

public delegate Task<IList<T>> InfinityScrollDelegate<T>(CancellationToken ct);