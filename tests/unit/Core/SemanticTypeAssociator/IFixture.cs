﻿namespace Paraminter.Semantic.Type.Apheleia;

using Moq;

using Paraminter.Arguments.Semantic.Type.Models;
using Paraminter.Associators.Commands;
using Paraminter.Commands.Handlers;
using Paraminter.Parameters.Type.Models;
using Paraminter.Semantic.Type.Apheleia.Models;

internal interface IFixture
{
    public abstract ICommandHandler<IAssociateArgumentsCommand<IAssociateSemanticTypeData>> Sut { get; }

    public abstract Mock<ICommandHandler<IRecordArgumentAssociationCommand<ITypeParameter, ISemanticTypeArgumentData>>> RecorderMock { get; }
    public abstract Mock<ICommandHandler<IInvalidateArgumentAssociationsRecordCommand>> InvalidatorMock { get; }
}
