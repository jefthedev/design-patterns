![Structural - Facade](https://user-images.githubusercontent.com/60556559/153747588-6c322c03-d3c3-4f56-a1b8-32d2cbf6c29e.png)

<p>This design pattern provides a unified interface to a set of interfaces in a <b>subsystem</b>. It defines a higher-level interface that makes the subsystem easier to use. A facade is an object that provides a simplified interface to a <b>larger</b> body of code, such as a class library.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>You need to wrap poorly-designed API's with a single well-designed API.</li>
	<li>You want to make a software library easier to use and understand, since Facade has convenient methods for common tasks.</li>
	<li>You want to reduce dependencies of outside code on the inner workings of a library, since most code uses Facade it allows more flexibility when developing the system.</li>
</ul>

<h2>Pros</h2>
<ul>
	<li>Combine very complex method calls and code blocks into a single method that performs a complex and recurring task.</li>
	<li>Reduces dependencies between libraries or packages, making programmers more apt to consideration before writing new code that exposes the inner workings of a library or package.</li>
	<li>Since the Facade makes a weak coupling between the client code and other packages or libraries it allows us to vary the internal components since the client does not call them directly.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>We have much less controll of what goes on beyond the surface. Also, if some classes require small variations to the implementation of Facade methods, we might end up with a mess.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF