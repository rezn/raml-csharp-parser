﻿/*
 * Copyright 2015 (c) Sergio Martin Pueyo.
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raml.Parser.Raml.Parser.Annotation
{
    public class Scalar : System.Attribute
    {
        bool _required;


    //Class< extends TupleRule> rule() default TupleRule.class;

    //Class<? extends  TupleBuilder> builder() default TupleBuilder.class;

    //Class<? extends TupleHandler> handler() default TupleHandler.class;

    String _alias;

    }
}
