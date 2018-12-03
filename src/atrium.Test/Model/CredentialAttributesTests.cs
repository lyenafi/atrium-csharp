/* 
 * MX API
 *
 * The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 
 *
 * OpenAPI spec version: 0.1
 * 
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using atrium.Api;
using atrium.Model;
using atrium.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace atrium.Test
{
    /// <summary>
    ///  Class for testing CredentialAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CredentialAttributesTests
    {
        // TODO uncomment below to declare an instance variable for CredentialAttributes
        //private CredentialAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CredentialAttributes
            //instance = new CredentialAttributes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CredentialAttributes
        /// </summary>
        [Test]
        public void CredentialAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CredentialAttributes
            //Assert.IsInstanceOfType<CredentialAttributes> (instance, "variable 'instance' is a CredentialAttributes");
        }


        /// <summary>
        /// Test the property 'FieldName'
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO unit test for the property 'FieldName'
        }
        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Test]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }
        /// <summary>
        /// Test the property 'Label'
        /// </summary>
        [Test]
        public void LabelTest()
        {
            // TODO unit test for the property 'Label'
        }
        /// <summary>
        /// Test the property 'Options'
        /// </summary>
        [Test]
        public void OptionsTest()
        {
            // TODO unit test for the property 'Options'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}