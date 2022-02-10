![Behavioral - Strategy](https://user-images.githubusercontent.com/60556559/152667864-33fcdd51-072c-4311-a235-baf53c6fd06d.png)

<p>You need to define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>You does not want your code to depend directly on third parties code.</li>
	<li>You need to use a class but its interface is incompatible with the interface of your client code.</li>
	<li>You want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.</li>
</ul>

<h2>Pros</h2>
<ul>
    <li>Provides an alternative to subclassing.</li>
	<li>Reduces multiple conditional statements in a client.</li>
	<li>Hides complex, algorithmic-specific data from the client.</li>
    <li>Can be used to hide data that an algorithm uses that clients shouldn't know about.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>Clients must be aware of different strategies. A client must understand how strategies differ before it can select the appropriate one.</li>
    <li>Increases the number of objects in application.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF