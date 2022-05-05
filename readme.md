# ch2

Microsoft.Extensions.Hosting contains dependencyinjection

## resolve types

    request an instance of service type, the container will find implmenting type, instantiate it if needed, and return it to you.
    if the implementation type has dependencies, they are provided to the implementing type as well

    var productImporter = host.Services.GetRequiredService<ProductImporter>();

### Dependency Inversion:

    High level modules should not depend on low-level modules

    A framework controls which code is executed next, not your code

    