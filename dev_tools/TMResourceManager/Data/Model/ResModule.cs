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

using System.Collections.Generic;

namespace TMResourceData.Model
{
    public class ResModule
    {
        public string Name { get; set; }
        public bool IsLock { get; set; }
        public List<ResWord> ListWords { get; set; }
        public Dictionary<WordStatusEnum, int> Counts { get; set; }

        public ResModule()
        {
            ListWords = new List<ResWord>();
            Counts = new Dictionary<WordStatusEnum, int>
                         {
                             {WordStatusEnum.Translated, 0},
                             {WordStatusEnum.Changed, 0},
                             {WordStatusEnum.All, 0},
                             {WordStatusEnum.Untranslated, 0}
                         };
        }
    }
}
