/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

//-----------------------------------------------------------------------
// <copyright file="FacebookClient.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.ApplicationBlock {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Web;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OAuth2;

	public class FacebookClient : WebServerClient {
		private static readonly AuthorizationServerDescription FacebookDescription = new AuthorizationServerDescription {
			TokenEndpoint = new Uri("https://graph.facebook.com/oauth/access_token"),
			AuthorizationEndpoint = new Uri("https://graph.facebook.com/oauth/authorize"),
            
		};

		/// <summary>
		/// Initializes a new instance of the <see cref="FacebookClient"/> class.
		/// </summary>
		public FacebookClient() : base(FacebookDescription, "","") {
         
		}
	}
}
