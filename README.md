# umbraco-spec

Umbraco by Specification

As spoken about [here](http://www.brendanmckenzie.com/blog/2015/01/umbraco-spec-file).  Allow developers to configure Umbraco using a specification file instead of forcing all CMS changes to happen through the Umbraco UI.

Simply add this package to your Umbraco project and set the location of the config JSON file in your web.config.  Whenever the Umbraco web application starts, it will read the JSON file and ensure the CMS matches what has been defined.
