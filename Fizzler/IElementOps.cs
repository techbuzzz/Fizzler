namespace Fizzler
{
    /// <summary>
    /// Represents a selectors implementation for an arbitrary document/node system.
    /// </summary>
    public interface IElementOps<TElement>
    {
        //
        // Selectors
        //

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#type-selectors">type selector</a>,
        /// which represents an instance of the element type in the document tree. 
        /// </summary>
        Selector<TElement> Type(string type);

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#universal-selector">universal selector</a>,
        /// any single element in the document tree in any namespace 
        /// (including those without a namespace) if no default namespace 
        /// has been specified for selectors. 
        /// </summary>
        Selector<TElement> Universal();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#Id-selectors">ID selector</a>,
        /// which represents an element instance that has an identifier that 
        /// matches the identifier in the ID selector.
        /// </summary>
        Selector<TElement> Id(string id);

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#class-html">class selector</a>,
        /// which is an alternative <see cref="AttributeIncludes"/> when 
        /// representing the <c>class</c> attribute. 
        /// </summary>
        Selector<TElement> Class(string clazz);

        //
        // Attribute selectors
        //

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the given attribute <paramref name="name"/>
        /// whatever the values of the attribute.
        /// </summary>
        Selector<TElement> AttributeExists(string name);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the given attribute <paramref name="name"/>
        /// and whose value is exactly <paramref name="value"/>.
        /// </summary>
        Selector<TElement> AttributeExact(string name, string value);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the given attribute <paramref name="name"/>
        /// and whose value is a whitespace-separated list of words, one of 
        /// which is exactly <paramref name="value"/>.
        /// </summary>
        Selector<TElement> AttributeIncludes(string name, string value);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the given attribute <paramref name="name"/>,
        /// its value either being exactly <paramref name="value"/> or beginning 
        /// with <paramref name="value"/> immediately followed by "-" (U+002D).
        /// </summary>
        Selector<TElement> AttributeDashMatch(string name, string value);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the attribute <paramref name="name"/> 
        /// whose value begins with the prefix <paramref name="value"/>.
        /// </summary>
        Selector<TElement> AttributePrefixMatch(string name, string value);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the attribute <paramref name="name"/> 
        /// whose value ends with the suffix <paramref name="value"/>.
        /// </summary>
        Selector<TElement> AttributeSuffixMatch(string name, string value);

        /// <summary>
        /// Generates an <a href="http://www.w3.org/TR/css3-selectors/#attribute-selectors">attribute selector</a>
        /// that represents an element with the attribute <paramref name="name"/> 
        /// whose value contains at least one instance of the substring <paramref name="value"/>.
        /// </summary>
        Selector<TElement> AttributeSubstring(string name, string value);

        //
        // Pseudo-class selectors
        //

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#pseudo-classes">pseudo-class selector</a>,
        /// which represents an element that is the first child of some other element.
        /// </summary>
        Selector<TElement> FirstChild();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#pseudo-classes">pseudo-class selector</a>,
        /// which represents an element that is the last child of some other element.
        /// </summary>
        Selector<TElement> LastChild();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#pseudo-classes">pseudo-class selector</a>,
        /// which represents an element that is the N-th child of some other element.
        /// </summary>
        Selector<TElement> NthChild(int a, int b);

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#pseudo-classes">pseudo-class selector</a>,
        /// which represents an elementthat has a parent element and whose parent 
        /// element has no other element children.
        /// </summary>
        Selector<TElement> OnlyChild();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#pseudo-classes">pseudo-class selector</a>,
        /// which represents an element that has no children at all.
        /// </summary>
        Selector<TElement> Empty();

        //
        // Combinators
        //

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#combinators">combinator</a>,
        /// which represents a childhood relationship between two elements.
        /// </summary>
        Selector<TElement> Child();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#combinators">combinator</a>,
        /// which represents a relationship between two elements where one element is an 
        /// arbitrary descendant of some ancestor element.
        /// </summary>
        Selector<TElement> Descendant();

        /// <summary>
        /// Generates a <a href="http://www.w3.org/TR/css3-selectors/#combinators">combinator</a>,
        /// which represents elements that share the same parent in the document tree and 
        /// where the first element immediately precedes the second element.
        /// </summary>
        Selector<TElement> Adjacent();
    }
}