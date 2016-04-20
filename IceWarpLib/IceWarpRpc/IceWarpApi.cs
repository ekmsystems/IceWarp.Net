﻿using System;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Ioc;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc
{
    public interface IIceWarpApi
    {
        /// <summary>
        /// Sends a request to the IceWarp Api
        /// </summary>
        /// <typeparam name="T">An implementation of IceWarpResponse. See <see cref="IceWarpResponse"/> for more information.</typeparam>
        /// <param name="url">The IceWarp server url</param>
        /// <param name="command">The Api request command. See <see cref="IceWarpCommand{T}"/> for more information.</param>
        /// <returns>The response from IceWarp</returns>
        /// <exception cref="IceWarpApiException">An error occurred when calling the Api</exception>
        /// <exception cref="ProcessResponseException">An error occurred when processing the response from the IceWarp Api</exception>
        /// <exception cref="NullReferenceException">A null or empty response returned from the IceWarp Api</exception>
        /// <exception cref="IceWarpErrorException">An error returned from the IceWarp Api</exception>
        T Execute<T>(string url, IceWarpCommand<T> command) where T : IceWarpResponse;
    }

    public class IceWarpApi : IIceWarpApi
    {
        private readonly IHttpUtility _httpUtility;

        public IceWarpApi()
        {
            var container = IocContainer.Container();
            _httpUtility = container.GetInstance<IHttpUtility>();
        }

        public IceWarpApi(IHttpUtility httpUtility)
        {
            _httpUtility = httpUtility;
        }

        /// <summary>
        /// Sends a request to the IceWarp Api
        /// </summary>
        /// <typeparam name="T">An implementation of IceWarpResponse</typeparam>
        /// <param name="url">The IceWarp server url</param>
        /// <param name="command">The Api request command</param>
        /// <returns>The response from IceWarp</returns>
        /// <exception cref="IceWarpApiException">An error occurred when calling the Api</exception>
        /// <exception cref="IceWarpErrorException">An error returned from the IceWarp Api</exception>
        public T Execute<T>(string url, IceWarpCommand<T> command) where T : IceWarpResponse
        {
            var response = _httpUtility.PostAsXml(url, command.ToXml().OuterXml);
            return command.FromHttpRequestResult(response);
        }
    }
}
