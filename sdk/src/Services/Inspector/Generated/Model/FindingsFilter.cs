/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as a request parameter in the <a>ListFindings</a> action.
    /// </summary>
    public partial class FindingsFilter
    {
        private List<Attribute> _attributes = new List<Attribute>();
        private List<string> _ruleNames = new List<string>();
        private List<string> _rulesPackageArns = new List<string>();
        private List<string> _severities = new List<string>();
        private List<Attribute> _userAttributes = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>attributes</b> property of the <a>Finding</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleNames. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>ruleName</b> property of the <a>Finding</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> RuleNames
        {
            get { return this._ruleNames; }
            set { this._ruleNames = value; }
        }

        // Check to see if RuleNames property is set
        internal bool IsSetRuleNames()
        {
            return this._ruleNames != null && this._ruleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>rulesPackageArn</b> property of the <a>Finding</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && this._rulesPackageArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>severity</b> property of the <a>Finding</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<string> Severities
        {
            get { return this._severities; }
            set { this._severities = value; }
        }

        // Check to see if Severities property is set
        internal bool IsSetSeverities()
        {
            return this._severities != null && this._severities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// be the exact match of the value of the <b>userAttributes</b> property of the <a>Finding</a>
        /// data type.
        /// </para>
        /// </summary>
        public List<Attribute> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && this._userAttributes.Count > 0; 
        }

    }
}