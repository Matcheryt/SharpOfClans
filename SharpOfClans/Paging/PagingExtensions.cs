namespace SharpOfClans.Paging
{
    public static class PagingExtensions
    {
        /// <summary>
        /// Creates a paging filter with the marker for the next page.
        /// </summary>
        /// <param name="paging">The paging returned by a previous endpoint call.</param>
        /// <returns>A paging filter with a cursor for the next page.</returns>
        public static PagingFilter NextPage(this Paging paging)
            => new()
            {
                After = paging.Cursors.After
            };

        /// <summary>
        /// Creates a paging filter with the marker for the previous page.
        /// </summary>
        /// <param name="paging">The paging returned by a previous endpoint call.</param>
        /// <returns>A paging filter with a cursor for the previous page.</returns>
        public static PagingFilter PreviousPage(this Paging paging)
            => new()
            {
                Before = paging.Cursors.Before
            };
    }
}
