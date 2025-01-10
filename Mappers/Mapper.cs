using System.Reflection;

namespace velocitaApi.Mappers
{
    public class Mapper
    {
        // Maps a DTO (Data Transfer Object) to a new instance of the target entity class.
        // Typically used for creating a new entity from a DTO.
        public static T DtoMapper<T>(object dto) where T : class, new()
        {
            // Validate that the DTO is not null
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "The DTO cannot be null.");
            }
            var target = new T();  // Create a new instance of the target object
            var targetType = typeof(T); // Type of the target object
            var sourceType = dto.GetType(); // Type of the DTO

            // Iterate over all public instance properties in the DTO
            // Find a property on the target object that matches the name and type
            foreach (var sourceProp in sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var targetProp = targetType.GetProperty(sourceProp.Name);
                if (targetProp != null && targetProp.CanWrite && // Property exists and is writable
                    targetProp.PropertyType == sourceProp.PropertyType) // Property types match
                {
                    var value = sourceProp.GetValue(dto); // Get the value from the DTO property
                    targetProp.SetValue(target, value); // Set the value to the matching property on the target object
                }
            }
            return target;
        }

        // Maps a DTO (or source object) to an existing target model object.
        // Typically used for updating an existing model with new values from a DTO.
        public static T DtoMapper<T>(object source, T target) where T : class
        {
            // Validate that the source object is not null
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "The source object cannot be null.");
            }
            // Validate that the target object is not null
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target), "The target object cannot be null.");
            }

            var sourceType = source.GetType(); // Type of the source object
            var targetType = target.GetType(); // Type of the target object

            // Iterate over all public instance properties in the source object
            foreach (var sourceProp in sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var targetProp = targetType.GetProperty(sourceProp.Name);
                if (targetProp != null && targetProp.CanWrite && // Property exists and is writable
                    targetProp.PropertyType == sourceProp.PropertyType) // Property types match
                {
                    var value = sourceProp.GetValue(source);    // Get the value from the source property
                    targetProp.SetValue(target, value); // Set the value to the matching property on the target object
                }
            }
            return target;
        }



        public static T MapCreate<T>(object dto) where T : class, new()
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "The DTO cannot be null.");
            }

            var target = new T();
            var targetType = typeof(T);
            var sourceType = dto.GetType();

            foreach (var sourceProp in sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var targetProp = targetType.GetProperty(sourceProp.Name);
                if (targetProp != null && targetProp.CanWrite &&
                    targetProp.PropertyType == sourceProp.PropertyType)
                {
                    var value = sourceProp.GetValue(dto);
                    targetProp.SetValue(target, value);
                }
            }

            return target;
        }
    }
}
