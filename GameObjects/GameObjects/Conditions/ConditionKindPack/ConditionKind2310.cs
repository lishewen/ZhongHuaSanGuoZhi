﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2310 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Architecture a)
        {
            return a.meinvkongjian() >= val;
        }

        public override bool CheckConditionKind(Faction faction)
        {
            int result = 0;
            foreach (Architecture a in faction.Architectures)
            {
                result += a.meinvkongjian();
            }
            return result >= val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }

    }
}

