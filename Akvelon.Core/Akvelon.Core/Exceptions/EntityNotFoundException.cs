namespace Akvelon.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() { }
        public EntityNotFoundException(string entity, params (string, string)[] searchParameters)
            : base($"The requested {entity} was not found with searched parameters :" +
                   $"{string.Join(", ", searchParameters.Select(pr => $"{pr.Item1}:{pr.Item2}"))}")
        {
        }

        public EntityNotFoundException(string entity, string additionalInfo, params (string, string)[] searchParameters)
            : base($"The requested {entity} was not found with searched parameters :" +
                   $"{string.Join(", ", searchParameters.Select(pr => $"{pr.Item1}:{pr.Item2}"))}. Additional info : {additionalInfo}")
        {
        }
    }
}
