using Backend_MusicTime.IAM.Domain.Model.Aggregates;
using Backend_MusicTime.IAM.Interfaces.REST.Resources;

namespace Backend_MusicTime.IAM.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User entity)
    {
        return new UserResource(entity.Id, entity.Username);
    }
}