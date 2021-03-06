﻿using Data_Access_Layer.Models;
using FluentValidation;
using Shared.DTos;

namespace Business_Layer.DTOValidation
{
    public class PlaneDTOValidator : AbstractValidator<PlaneDTO>
    {
        public PlaneDTOValidator()
        {
            RuleFor(p => p.PlaneType).NotNull();
        }
    }
}