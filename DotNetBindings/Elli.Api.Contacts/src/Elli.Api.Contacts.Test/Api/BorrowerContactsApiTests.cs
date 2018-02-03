/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Contacts
 *
 * Represents borrower and business contacts
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Model;

namespace Elli.Api.Contacts.Test
{
    /// <summary>
    ///  Class for testing BorrowerContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BorrowerContactsApiTests
    {
        private BorrowerContactsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BorrowerContactsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BorrowerContactsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BorrowerContactsApi
            //Assert.IsInstanceOfType(typeof(BorrowerContactsApi), instance, "instance is a BorrowerContactsApi");
        }

        
        /// <summary>
        /// Test CreateContact
        /// </summary>
        [Test]
        public void CreateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BorrowerContactContract contact = null;
            //string allowEmpty = null;
            //instance.CreateContact(contact, allowEmpty);
            
        }
        
        /// <summary>
        /// Test CreateContactNote
        /// </summary>
        [Test]
        public void CreateContactNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //ContactNoteContract note = null;
            //instance.CreateContactNote(contactId, note);
            
        }
        
        /// <summary>
        /// Test DeleteContact
        /// </summary>
        [Test]
        public void DeleteContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //instance.DeleteContact(contactId);
            
        }
        
        /// <summary>
        /// Test DeleteContactNote
        /// </summary>
        [Test]
        public void DeleteContactNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //string noteId = null;
            //instance.DeleteContactNote(contactId, noteId);
            
        }
        
        /// <summary>
        /// Test GetContact
        /// </summary>
        [Test]
        public void GetContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //var response = instance.GetContact(contactId);
            //Assert.IsInstanceOf<BorrowerContactContract> (response, "response is BorrowerContactContract");
        }
        
        /// <summary>
        /// Test GetContactNote
        /// </summary>
        [Test]
        public void GetContactNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //string noteId = null;
            //var response = instance.GetContactNote(contactId, noteId);
            //Assert.IsInstanceOf<ContactNoteContract> (response, "response is ContactNoteContract");
        }
        
        /// <summary>
        /// Test GetContactNotes
        /// </summary>
        [Test]
        public void GetContactNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //var response = instance.GetContactNotes(contactId);
            //Assert.IsInstanceOf<List<ContactNoteContract>> (response, "response is List<ContactNoteContract>");
        }
        
        /// <summary>
        /// Test UpdateContact
        /// </summary>
        [Test]
        public void UpdateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //BorrowerContactContract contact = null;
            //string allowEmpty = null;
            //var response = instance.UpdateContact(contactId, contact, allowEmpty);
            //Assert.IsInstanceOf<BorrowerContactContract> (response, "response is BorrowerContactContract");
        }
        
        /// <summary>
        /// Test UpdateContactNote
        /// </summary>
        [Test]
        public void UpdateContactNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contactId = null;
            //string noteId = null;
            //ContactNoteContract contactNoteContract = null;
            //var response = instance.UpdateContactNote(contactId, noteId, contactNoteContract);
            //Assert.IsInstanceOf<ContactNoteContract> (response, "response is ContactNoteContract");
        }
        
    }

}