using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Builder;

namespace RCLib.Shared
{
    public static class AddComponentsBuilderExtensions
    {
        public static IEndpointConventionBuilder AddComponents(this IEndpointConventionBuilder builder, Assembly appAssembly)
        {
            if (appAssembly == null)
            {
                throw new ArgumentNullException(nameof(appAssembly));
            }

            var types = ComponentResolver.ResolveComponents(appAssembly);
            foreach (Type t in types)
            {
                builder.AddComponent(t, t.Name.ToLower());
            }

            return builder;
        }
    }
}
