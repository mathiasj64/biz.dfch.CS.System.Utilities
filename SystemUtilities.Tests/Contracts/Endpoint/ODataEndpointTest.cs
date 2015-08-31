/**
 * Copyright 2015 Marc Rufer, d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

﻿using System;
﻿using biz.dfch.CS.Utilities.Contracts.Endpoint;
﻿using Microsoft.Data.Edm;
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Utilities.Tests.Contracts.Endpoint
{
    [TestClass]
    public class ODataEndpointTest : IODataEndpoint
    {
        public IEdmModel GetModel()
        {
            throw new NotImplementedException();
        }

        private readonly String containerName = "myContainer";
        public string GetContainerName()
        {
            return containerName;
        }

        [TestMethod]
        public void IODataEndpointGetContainerNameReturnsName()
        {
            Assert.AreEqual(containerName, this.GetContainerName());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void IODataEndpointGetModelThrowsNotImplementedException()
        {
            this.GetModel();
            Assert.Fail("Exception expected, but no exception has been thrown.");
        }
    }
}
