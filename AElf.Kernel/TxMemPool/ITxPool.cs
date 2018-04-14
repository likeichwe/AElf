﻿using System.Collections.Generic;
using AElf.Kernel.TxMemPool;

namespace AElf.Kernel
{
    public interface ITxPool
    {
        /// <summary>
        /// add tx
        /// </summary>
        /// <param name="tx"></param>
        /// <returns></returns>
        bool AddTx(ITransaction tx);

        /// <summary>
        /// remove a tx
        /// </summary>
        /// <param name="tx"></param>
        bool DisgardTx(ITransaction tx);

        /// <summary>
        /// promote txs from waiting to executable
        /// </summary>
        /// <param name="addrs"></param>
        void Promote(List<Hash> addrs);

        /// <summary>
        /// validate a tx before added to pool    
        /// </summary>
        /// <param name="tx"></param>
        /// <returns></returns>
        bool ValidateTx(ITransaction tx);

        /// <summary>
        /// return pool size
        /// </summary>
        /// <returns></returns>
        int GetPoolSize();

        /// <summary>
        /// minimal fee needed
        /// </summary>
        /// <returns></returns>
        Fee MinimalFee();
        
        /// <summary>
        /// return a tx alread in pool
        /// </summary>
        /// <param name="txHash"></param>
        /// <param name="tx"></param>
        /// <returns></returns>
        bool GetTransaction(Hash txHash, out ITransaction tx);
    }
}