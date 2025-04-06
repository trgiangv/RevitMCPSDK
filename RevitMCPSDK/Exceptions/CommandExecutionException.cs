﻿// 
//                       RevitAPI-Solutions
// Copyright (c) Duong Tran Quang (DTDucas) (baymax.contact@gmail.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//

using RevitMCPSDK.API.Models;

namespace RevitMCPSDK.Exceptions
{
    public class CommandExecutionException : Exception
    {
        public int ErrorCode { get; }
        public object ErrorData { get; }

        public CommandExecutionException(string message)
            : base(message)
        {
            ErrorCode = JsonRPCErrorCodes.InternalError;
        }

        public CommandExecutionException(string message, int errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public CommandExecutionException(string message, int errorCode, object errorData)
            : base(message)
        {
            ErrorCode = errorCode;
            ErrorData = errorData;
        }
    }
}
