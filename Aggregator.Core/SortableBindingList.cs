using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aggregator.Core
{
    public class SortableBindingList<T> : BindingList<T>
    {
        internal class SortComparer<T> : IComparer<T>
        {
            private PropertyDescriptor m_PropDesc = null;
            private ListSortDirection m_Direction = ListSortDirection.Ascending;

            public SortComparer(PropertyDescriptor propDesc, ListSortDirection direction)
            {
                m_PropDesc = propDesc;
                m_Direction = direction;
            }

            public int Compare(T x, T y)
            {
                object xValue = m_PropDesc.GetValue(x);
                object yValue = m_PropDesc.GetValue(y);
                return CompareValues(xValue, yValue, m_Direction);
            }

            private int CompareValues(object xValue, object yValue, ListSortDirection direction)
            {
                int retValue = 0;
                if (xValue is IComparable) //can ask the x value
                {
                    retValue = ((IComparable)xValue).CompareTo(yValue);
                }
                else if (yValue is IComparable) //can ask the y value
                {
                    retValue = ((IComparable)yValue).CompareTo(xValue);
                }
                //not comparable, compare string representations
                else if (!xValue.Equals(yValue))
                {
                    retValue = xValue.ToString().CompareTo(yValue.ToString());
                }
                if (direction == ListSortDirection.Ascending)
                    return retValue;
                else
                    return retValue * -1;
            }
        }

        private bool m_Sorted = false;
        private ListSortDirection m_SortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor m_SortProperty = null;

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

        protected override bool IsSortedCore
        {
            get
            {
                return m_Sorted;
            }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return m_SortDirection;
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return m_SortProperty;
            }
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            m_SortDirection = direction;
            m_SortProperty = prop;
            var listRef = this.Items as List<T>;
            if (listRef == null)
                return;
            var comparer = new SortComparer<T>(prop, direction);

            listRef.Sort(comparer);

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}
