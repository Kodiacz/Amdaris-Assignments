﻿namespace PetCare.Interfaces
{
    using PetCare.Domain.Entities;
using System.Linq.Expressions;

    public interface IPetRepository
    {
        /// <summary>
        /// Adding a Pet type entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        Task AddAsync(Pet pet);

        /// <summary>
        /// Updating the Pet entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Pet pet);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        Task<Pet> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Pet type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Pet>> GetAllAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<Pet>> GetAllAsync(Expression<Func<Pet, bool>> search);

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="пет">Pet entity</param>
        /// <returns></returns>
        void DeleteSoftAsync(Pet pet);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();
    }
}
