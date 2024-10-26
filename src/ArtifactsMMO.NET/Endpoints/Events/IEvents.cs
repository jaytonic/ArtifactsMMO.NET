﻿using ArtifactsMMO.NET.Objects.Events;
using ArtifactsMMO.NET.Objects;
using ArtifactsMMO.NET.Queries;
using System.Threading.Tasks;
using System.Threading;
using ArtifactsMMO.NET.Exceptions;

namespace ArtifactsMMO.NET.Endpoints.Events
{
    /// <summary>
    /// Provides methods for retrieving event-related information.
    /// </summary>
    public interface IEvents
    {
        /// <summary>
        /// Fetch events details.
        /// </summary>
        /// <param name="eventsQuery">The query <see cref="EventsQuery"/> to filter events.</param>
        /// <param name="cancellationToken">A token for canceling the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation.
        /// The task result contains a <see cref="PagedResponse{Event}"/> with the filtered events.</returns>
        /// <exception cref="ApiException"></exception>
        Task<PagedResponse<Event>> GetAsync(EventsQuery eventsQuery, CancellationToken cancellationToken = default);
    }
}
