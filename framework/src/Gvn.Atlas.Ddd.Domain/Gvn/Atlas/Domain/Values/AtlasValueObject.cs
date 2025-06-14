﻿using System.Collections.Generic;

namespace Gvn.Atlas.Domain.Values
{
    public abstract class AtlasValueObject
    {
        protected abstract IEnumerable<object> GetAtomicValues();

        public bool ValueEquals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (AtlasValueObject)obj;

            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();
            
            var thisMoveNext= thisValues.MoveNext();
            var otherMoveNext = otherValues.MoveNext();
            while (thisMoveNext && otherMoveNext)
            {
                if (ReferenceEquals(thisValues.Current, null) ^ ReferenceEquals(otherValues.Current, null))
                {
                    return false;
                }

                if (thisValues.Current is AtlasValueObject currentValueObject && otherValues.Current is AtlasValueObject otherValueObject)
                {
                    if (!currentValueObject.ValueEquals(otherValueObject))
                    {
                        return false;
                    }
                }
                else if (thisValues.Current != null && !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }

                thisMoveNext = thisValues.MoveNext();
                otherMoveNext = otherValues.MoveNext();

                if (thisMoveNext != otherMoveNext)
                {
                    return false;
                }
            }

            return !thisMoveNext && !otherMoveNext;
        }
    }
}