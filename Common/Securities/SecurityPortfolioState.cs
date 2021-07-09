/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

using System;
using System.Collections.Generic;
using QuantConnect.Securities.Positions;

namespace QuantConnect.Securities
{
    /// <summary>
    /// Snapshot of an algorithms portfolio state
    /// </summary>
    public class SecurityPortfolioState
    {
        /// <summary>
        /// The utc time this state was captured
        /// </summary>
        public DateTime UtcTime { get; set; }

        /// <summary>
        /// The current total portfolio value
        /// </summary>
        public decimal TotalPortfolioValue { get; set; }

        /// <summary>
        /// The margin used
        /// </summary>
        public decimal TotalMarginUsed { get; set; }

        /// <summary>
        /// The holdings
        /// </summary>
        public List<PositionGroupState> Holdings { get; set; }
    }

    /// <summary>
    /// Snapshot of a position group state
    /// </summary>
    public class PositionGroupState
    {
        /// <summary>
        /// Currently margin used
        /// </summary>
        public decimal MarginUsed { get; set; }

        /// <summary>
        /// The margin used by this position in relation to the total portfolio value
        /// </summary>
        public decimal PortfolioValuePercentage { get; set; }

        /// <summary>
        /// THe positions which compose this group
        /// </summary>
        public List<IPosition> Positions { get; set; }
    }
}
