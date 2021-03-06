﻿#region License
/**
 * Copyright (c) 2015, 何志祥 (strangecity@qq.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * without warranties or conditions of any kind, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion

namespace Zaabee.Dapper.Lambda
{
	public static class Expression2SqlEx
	{
		public static bool Like(this object obj, string value)
		{
			return true;
		}

		/// <summary>
		/// like '% _ _ _'
		/// </summary>
		public static bool LikeLeft(this object obj, string value)
		{
			return true;
		}

		/// <summary>
		/// like '_ _ _ %'
		/// </summary>
		public static bool LikeRight(this object obj, string value)
		{
			return true;
		}

		public static bool In<T>(this object obj, params T[] ary)
		{
			return true;
		}
	}
}