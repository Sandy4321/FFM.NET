using System;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace FFM.NET.Generator
{
    public class SampleLibrary : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.OutputDir = @"..\..\..\FFM.NET\";
            options.GeneratorKind = GeneratorKind.CSharp;
            var module = options.AddModule("Core");
            module.Headers.Add(@"C:\Projects\other\libffm\ffm.h");
        }

        public void SetupPasses(Driver driver)
        {
        }
    }
}