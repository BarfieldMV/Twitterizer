﻿//-----------------------------------------------------------------------
// <copyright file="PublicTimelineCommand.cs" company="Patrick 'Ricky' Smith">
//  This file is part of the Twitterizer library (http://code.google.com/p/twitterizer/)
// 
//  Copyright (c) 2010, Patrick "Ricky" Smith (ricky@digitally-born.com)
//  All rights reserved.
//  
//  Redistribution and use in source and binary forms, with or without modification, are 
//  permitted provided that the following conditions are met:
// 
//  - Redistributions of source code must retain the above copyright notice, this list 
//    of conditions and the following disclaimer.
//  - Redistributions in binary form must reproduce the above copyright notice, this list 
//    of conditions and the following disclaimer in the documentation and/or other 
//    materials provided with the distribution.
//  - Neither the name of the Twitterizer nor the names of its contributors may be 
//    used to endorse or promote products derived from this software without specific 
//    prior written permission.
// 
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
//  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
//  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
//  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
//  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
//  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
//  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
//  POSSIBILITY OF SUCH DAMAGE.
// </copyright>
// <author>Ricky Smith</author>
// <summary>The command to obtain the public timeline</summary>
//-----------------------------------------------------------------------
namespace Twitterizer.Commands
{
    using System;
    using Twitterizer.Core;

    /// <summary>
    /// The Public Timeline Command class
    /// </summary>
    internal sealed class PublicTimelineCommand :
        Core.BaseCommand<TwitterStatusCollection>,
        Core.IPagedCommand<TwitterStatusCollection>
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTimelineCommand"/> class.
        /// </summary>
        /// <param name="tokens">The request tokens.</param>
        public PublicTimelineCommand(OAuthTokens tokens)
            : base("GET", new Uri("http://api.twitter.com/1/statuses/public_timeline.json"), tokens)
        {
        }
        #endregion

        #region IPagedCommand<TwitterStatusCollection> Members

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        /// <value>The cursor.</value>
        /// <remarks>
        /// Optional.
        /// Breaks the results into pages.
        /// A single page contains 100 users.
        /// </remarks>
        long IPagedCommand<TwitterStatusCollection>.Cursor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets the page number to obtain.
        /// </summary>
        /// <value>The page number.</value>
        int IPagedCommand<TwitterStatusCollection>.Page
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="Twitterizer.Core.IPagedCommand{T}"/> interface.
        /// </returns>
        IPagedCommand<TwitterStatusCollection> IPagedCommand<TwitterStatusCollection>.Clone()
        {
            throw new NotImplementedException();
        }

        #endregion

        /// <summary>
        /// Initializes the command.
        /// </summary>
        public override void Init()
        {
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        public override void Validate()
        {
            this.IsValid = true;
        }
    }
}
